using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Clefairy : Pokemon
{
	public override string Name => "Clefairy";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Cutecharm(), new Abilities.Magicguard() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Friendguard() };
	public override Stats BaseStats => new Stats(70, 45, 48, 60, 65, 35);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Sing(), new Moves.Sweetkiss(), new Moves.Disarmingvoice(), new Moves.Encore(), new Moves.Charm(), new Moves.Splash(), new Moves.Pound(), new Moves.Copycat(), new Moves.Growl(), new Moves.Defensecurl() },
		[4] = new List<Move>() { new Moves.Storedpower() },
		[8] = new List<Move>() { new Moves.Minimize() },
		[12] = new List<Move>() { new Moves.Afteryou() },
		[16] = new List<Move>() { new Moves.Lifedew() },
		[20] = new List<Move>() { new Moves.Metronome() },
		[24] = new List<Move>() { new Moves.Moonlight() },
		[28] = new List<Move>() { new Moves.Gravity() },
		[32] = new List<Move>() { new Moves.Meteormash() },
		[36] = new List<Move>() { new Moves.Followme() },
		[40] = new List<Move>() { new Moves.Cosmicpower() },
		[44] = new List<Move>() { new Moves.Moonblast() },
		[48] = new List<Move>() { new Moves.Healingwish() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Charm(), new Moves.Cosmicpower(), new Moves.Dazzlinggleam(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drainingkiss(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Dualwingbeat(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Flash(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Meteorbeam(), new Moves.Metronome(), new Moves.Mistyexplosion(), new Moves.Mistyterrain(), new Moves.Mysticalfire(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Storedpower(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Triattack(), new Moves.Trick(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Wonderroom(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 75;
	public override int ExpYield => 113;
	public override int CatchRate => 150;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 2,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}