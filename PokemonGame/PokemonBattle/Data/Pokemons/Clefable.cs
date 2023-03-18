using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Clefable : Pokemon
	{
		public override string Name => "Clefable";
		public override List<Ability> AvailableAbilities => new() {new Cutecharm(), new Magicguard() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unaware() };
		public override Stats BaseStats => new Stats(95, 70, 73, 95, 90, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Sing(), new Sweetkiss(), new Disarmingvoice(), new Encore(), new Charm(), new Storedpower(), new Minimize(), new Afteryou(), new Lifedew(), new Metronome(), new Moonlight(), new Gravity(), new Meteormash(), new Followme(), new Cosmicpower(), new Moonblast(), new Healingwish(), new Splash(), new Pound(), new Copycat(), new Growl(), new Defensecurl() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Amnesia(), new Attract(), new Batonpass(), new Blizzard(), new Bodyslam(), new Bounce(), new Brickbreak(), new Calmmind(), new Chargebeam(), new Charm(), new Cosmicpower(), new Dazzlinggleam(), new Dig(), new Doubleteam(), new Drainingkiss(), new Drainpunch(), new Dreameater(), new Dualwingbeat(), new Encore(), new Endure(), new Facade(), new Faketears(), new Fireblast(), new Firepunch(), new Flamethrower(), new Flash(), new Fling(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icepunch(), new Icywind(), new Imprison(), new Irontail(), new Lightscreen(), new Magicalleaf(), new Megakick(), new Megapunch(), new Meteorbeam(), new Metronome(), new Mistyexplosion(), new Mistyterrain(), new Mysticalfire(), new Playrough(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Retaliate(), new Rocksmash(), new Round(), new Safeguard(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stealthrock(), new Storedpower(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Triattack(), new Trick(), new Uproar(), new Waterpulse(), new Wonderroom(), new Workup(), new Zenheadbutt() };
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
}