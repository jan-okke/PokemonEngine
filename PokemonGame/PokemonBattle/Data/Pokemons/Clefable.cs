using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Clefable : Pokemon
{
	public override string Name => "Clefable";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Cutecharm(), new Abilities.Magicguard() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Unaware() };
	public override Stats BaseStats => new Stats(95, 70, 73, 95, 90, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Sing(), new Moves.Sweetkiss(), new Moves.Disarmingvoice(), new Moves.Encore(), new Moves.Charm(), new Moves.Storedpower(), new Moves.Minimize(), new Moves.Afteryou(), new Moves.Lifedew(), new Moves.Metronome(), new Moves.Moonlight(), new Moves.Gravity(), new Moves.Meteormash(), new Moves.Followme(), new Moves.Cosmicpower(), new Moves.Moonblast(), new Moves.Healingwish(), new Moves.Splash(), new Moves.Pound(), new Moves.Copycat(), new Moves.Growl(), new Moves.Defensecurl() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Charm(), new Moves.Cosmicpower(), new Moves.Dazzlinggleam(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drainingkiss(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Dualwingbeat(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Meteorbeam(), new Moves.Metronome(), new Moves.Mistyexplosion(), new Moves.Mistyterrain(), new Moves.Mysticalfire(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Storedpower(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Triattack(), new Moves.Trick(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Wonderroom(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 400;
	public override int ExpYield => 242;
	public override int CatchRate => 25;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 3,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}