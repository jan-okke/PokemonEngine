using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Chimecho : Pokemon
	{
		public override string Name => "Chimecho";
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override Stats BaseStats => new Stats(75, 50, 80, 65, 95, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Healingwish(), new Wrap(), new Growl(), new Astonish(), new Confusion() },
			[4] = new List<Move>() { new Growl() },
			[7] = new List<Move>() { new Astonish() },
			[10] = new List<Move>() { new Confusion() },
			[13] = new List<Move>() { new Yawn() },
			[16] = new List<Move>() { new Lightscreen() },
			[19] = new List<Move>() { new Takedown() },
			[22] = new List<Move>() { new Extrasensory() },
			[27] = new List<Move>() { new Healbell() },
			[32] = new List<Move>() { new Uproar() },
			[37] = new List<Move>() { new Safeguard() },
			[42] = new List<Move>() { new Doubleedge() },
			[47] = new List<Move>() { new Healpulse() },
			[52] = new List<Move>() { new Psychic() },
			[57] = new List<Move>() { new Healingwish() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Bind(), new Calmmind(), new Chargebeam(), new Confide(), new Dazzlinggleam(), new Doubleteam(), new Dreameater(), new Echoedvoice(), new Endure(), new Energyball(), new Facade(), new Flash(), new Frustration(), new Grassknot(), new Gravity(), new Healbell(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Icywind(), new Knockoff(), new Laserfocus(), new Lastresort(), new Lightscreen(), new Magiccoat(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Return(), new Round(), new Safeguard(), new Shadowball(), new Shockwave(), new Signalbeam(), new Skillswap(), new Sleeptalk(), new Snatch(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Telekinesis(), new Thunderwave(), new Torment(), new Trick(), new Trickroom(), new Uproar(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Cosmicpower(), new Curse(), new Disable(), new Futuresight(), new Hypnosis(), new Perishsong(), new Recover(), new Storedpower(), new Wish() };
		public override int Weight => 10;
		public override int ExpYield => 159;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}