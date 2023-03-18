using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Kirlia : Pokemon
	{
		public override string Name => "Kirlia";
		public override List<Ability> AvailableAbilities => new() {new Synchronize(), new Trace() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Telepathy() };
		public override Stats BaseStats => new Stats(38, 35, 35, 65, 55, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Growl(), new Disarmingvoice(), new Doubleteam(), new Confusion() },
			[9] = new List<Move>() { new Hypnosis() },
			[12] = new List<Move>() { new Drainingkiss() },
			[15] = new List<Move>() { new Teleport() },
			[18] = new List<Move>() { new Psybeam() },
			[23] = new List<Move>() { new Lifedew() },
			[28] = new List<Move>() { new Charm() },
			[33] = new List<Move>() { new Calmmind() },
			[38] = new List<Move>() { new Psychic() },
			[43] = new List<Move>() { new Healpulse() },
			[48] = new List<Move>() { new Dreameater() },
			[53] = new List<Move>() { new Futuresight() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Bodyslam(), new Calmmind(), new Chargebeam(), new Charm(), new Dazzlinggleam(), new Doubleteam(), new Drainingkiss(), new Dreameater(), new Encore(), new Endure(), new Expandingforce(), new Facade(), new Firepunch(), new Flash(), new Fling(), new Futuresight(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Icepunch(), new Icywind(), new Imprison(), new Lightscreen(), new Magicalleaf(), new Magicroom(), new Megakick(), new Megapunch(), new Mistyterrain(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Shadowball(), new Shockwave(), new Skillswap(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Taunt(), new Thief(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Torment(), new Trick(), new Trickroom(), new Tripleaxel(), new Willowisp(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 202;
		public override int ExpYield => 97;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}