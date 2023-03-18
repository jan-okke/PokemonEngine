using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Jynx : Pokemon
	{
		public override string Name => "Jynx";
		public override List<Ability> AvailableAbilities => new() {new Oblivious(), new Forewarn() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Dryskin() };
		public override Stats BaseStats => new Stats(65, 50, 35, 115, 95, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Sweetkiss(), new Lick(), new Pound(), new Powdersnow(), new Copycat() },
			[12] = new List<Move>() { new Confusion() },
			[16] = new List<Move>() { new Covet() },
			[20] = new List<Move>() { new Sing() },
			[24] = new List<Move>() { new Faketears() },
			[28] = new List<Move>() { new Icepunch() },
			[34] = new List<Move>() { new Psychic() },
			[40] = new List<Move>() { new Lovelykiss() },
			[46] = new List<Move>() { new Meanlook() },
			[52] = new List<Move>() { new Perishsong() },
			[58] = new List<Move>() { new Blizzard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Avalanche(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Calmmind(), new Charm(), new Doubleteam(), new Drainingkiss(), new Drainpunch(), new Dreameater(), new Encore(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Faketears(), new Flash(), new Fling(), new Focusblast(), new Focuspunch(), new Futuresight(), new Gigaimpact(), new Grassknot(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icepunch(), new Iciclespear(), new Icywind(), new Lightscreen(), new Magicroom(), new Megakick(), new Megapunch(), new Metronome(), new Nastyplot(), new Payback(), new Protect(), new Psychic(), new Psychicterrain(), new Psychocut(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Round(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute(), new Swagger(), new Taunt(), new Thief(), new Torment(), new Trick(), new Trickroom(), new Tripleaxel(), new Uproar(), new Waterpulse(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 406;
		public override int ExpYield => 159;
		public override int CatchRate => 45;
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